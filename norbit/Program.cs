using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы для работы с контроллерами
builder.Services.AddControllers();

var app = builder.Build();

// Разрешаем серверу отдавать статические файлы из папки wwwroot
app.UseStaticFiles();  // Эта строка позволяет серверу отдавать файлы из wwwroot

// Настройка порта для HTTPS
app.UseHttpsRedirection();  // Если используешь HTTPS

// Обработка всех других запросов и перенаправление на index.html
app.MapFallbackToFile("index.html");

// Регистрируем маршруты для контроллеров API
app.MapControllers();

// Указываем, что сервер должен работать на порту 7056
app.Run("https://localhost:7056");  // Настроили сервер на порт 7056

