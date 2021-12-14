using AllForOne.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<AskingQuestionsService>();
builder.Services.AddScoped<GreaterOrLessService>();
builder.Services.AddScoped<SayHelloService>();
builder.Services.AddScoped<TwoNumbersService>();
builder.Services.AddScoped<OddEvenService>();
builder.Services.AddScoped<ReverseItService>();
builder.Services.AddScoped<MadLibServices>();
builder.Services.AddScoped<Magic8BallService>();
builder.Services.AddScoped<RestaurantPickerService>();

///CORS Policy to access Frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
    builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();

    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
