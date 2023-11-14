using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController: Controller{

    // course/index
    public string Index(){
        /*
        // dotnet watch run ile homecontroler içindeki sayfaya gitti ben sonrasında:
        http://localhost:5250/course/index ekleyince o sayfa açıldı ve course/index bu çıktıyı aldım

        http://localhost:5250/course/ böylede yapsam yine index kısmına gider çünkü otomatik dolduruyor ben default fonk. da belirttim:
        yeri program.cs de
        app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); kısmı.
        */
        return "course/index";// geri dönüş
    }
    
    // course/list
    public string List(){
        return "course/list";
    }
}