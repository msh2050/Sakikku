var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.AddJsonFile("appsettings.json").
        AddJsonFile($"appsettings.docker.json", true).AddEnvironmentVariables();
});

var connectionString = builder.Configuration.GetConnectionString("Default")
    ?? "Host = localhost; Database = ProductsDb; Username = admin; Password = admin1234; Pooling = true; ";


builder.Services.AddScoped<IDataRepository, DataRepository>();


//builder.Services.AddDbContext<ApiDbContext>(opt =>
//        opt.UseNpgsql(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddDbContext<ApiDbContext>(opt =>
        opt.UseNpgsql(connectionString));


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = builder.Environment.ApplicationName, Version = "v1" });
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{builder.Environment.ApplicationName} v1"));
}
//var options = new JsonSerializerOptions(JsonSerializerDefaults.Web)
//{
//    //Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
//    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic, UnicodeRanges.Arabic, UnicodeRanges.Latin1Supplement),
//    WriteIndented = true,
//    PropertyNameCaseInsensitive = false,
//    PropertyNamingPolicy = null,
//};

app.MapGet("/", () => 
new { FirstName = "Gérald", LastName = "  مطصفى  " }
//Results.Json( new { FirstName = "Gérald", LastName = "  مطصفى سلمان  " }, options)
);

app.MapGet("/product/{id:guid}", async ([FromServices] IDataRepository db, Guid id) =>
{
    
    return await db.GetProduct(id) is Product product ? Results.Ok(product) : Results.NotFound();
   
});


app.MapGet("/products", ([FromServices] IDataRepository db) =>
{
    return db.GetAllProducts();
}
);

app.MapPut("/product/{id:guid}", ([FromServices] IDataRepository db, Product product) =>
{
    return db.UpdateProduct(product);
});

app.MapPost("/product", ([FromServices] IDataRepository db, Product product) =>
{
    return db.AddProduct(product);
});

app.MapDelete("/product/{id:guid}", ([FromServices] IDataRepository db, Guid id) =>
{
    return db.DeleteProduct(id);
});
app.MapGet("/product/{product}", ([FromServices] IDataRepository db, string product) =>
{
    return db.FindProduct(product);
});


app.Run();
