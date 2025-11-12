using energyEC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// MVC を使えるように登録
builder.Services.AddControllersWithViews();

// DbContext を登録（SQL Server 用）
// ※ 接続文字列は自分の環境に合わせて変更してください
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        "server=localhost;database=energyec;user=root;password=Aimino1103",
        new MySqlServerVersion(new Version(8, 0, 33))
    ));

var app = builder.Build();

// 開発中は詳細エラーを表示
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ルート設定（デフォルト）
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
