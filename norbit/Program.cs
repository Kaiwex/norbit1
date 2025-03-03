using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// ��������� ������� ��� ������ � �������������
builder.Services.AddControllers();

var app = builder.Build();

// ��������� ������� �������� ����������� ����� �� ����� wwwroot
app.UseStaticFiles();  // ��� ������ ��������� ������� �������� ����� �� wwwroot

// ��������� ����� ��� HTTPS
app.UseHttpsRedirection();  // ���� ����������� HTTPS

// ��������� ���� ������ �������� � ��������������� �� index.html
app.MapFallbackToFile("index.html");

// ������������ �������� ��� ������������ API
app.MapControllers();

// ���������, ��� ������ ������ �������� �� ����� 7056
app.Run("https://localhost:7056");  // ��������� ������ �� ���� 7056

