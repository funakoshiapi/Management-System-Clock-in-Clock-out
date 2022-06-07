using Bunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using PROJECT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PROJECT_tests
{
    public class AssetManagementOperations
    {
        [Fact]
        public async void InsertNewWorker()
        {

            using var context = new TestContext();

            context.JSInterop.SetupVoid("mudHandlePortal", _ => true);
 
            context.Services.AddMudServices(); 
            context.Services.AddDbContext<ContextForDB>(options =>
                         options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ManningProject;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False"));
          
                var renderresult = context.RenderComponent<PROJECT1.Pages.ManagementPages.ManageFarmAssetsPage>();
            
                var button1 = renderresult.Find("#btadd1");
                var input_firstname = renderresult.Find("#input_firstname");
                var input_lastname = renderresult.Find("#input_lastname");

                var resultbox = renderresult.Find("#p_success1");

                input_firstname.Change(Guid.NewGuid().ToString());
                input_lastname.Change(Guid.NewGuid().ToString());

            // button1.Click();
            // await Task.Delay(2000);
            // use that, or this:
            await button1.ClickAsync(new Microsoft.AspNetCore.Components.Web.MouseEventArgs());
               
                Assert.Equal("New worker added",resultbox.TextContent); 
               
        }

        [Fact]
        public async void InsertNewJob()
        {

            using var context = new TestContext();

            context.JSInterop.SetupVoid("mudHandlePortal", _ => true);

            context.Services.AddMudServices();
            context.Services.AddDbContext<ContextForDB>(options =>
                         options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ManningProject;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False"));

            var renderresult = context.RenderComponent<PROJECT1.Pages.ManagementPages.ManageFarmAssetsPage>();

            var button2 = renderresult.Find("#btadd2");
            var input_jobtitle = renderresult.Find("#input_jobtitle"); 

            var resultbox = renderresult.Find("#p_success2");

            input_jobtitle.Change(Guid.NewGuid().ToString()); 
             
            await button2.ClickAsync(new Microsoft.AspNetCore.Components.Web.MouseEventArgs());

            Assert.Equal("New job added", resultbox.TextContent);

        }


        [Fact]
        public async void InsertNewBuilding()
        {

            using var context = new TestContext();

            context.JSInterop.SetupVoid("mudHandlePortal", _ => true);

            context.Services.AddMudServices();
            context.Services.AddDbContext<ContextForDB>(options =>
                         options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBPROJECTManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            var renderresult = context.RenderComponent<PROJECT1.Pages.ManagementPages.ManageFarmAssetsPage>();

            var button3 = renderresult.Find("#btadd3");
            var input_jobtitle = renderresult.Find("#input_buildingtitle");

            var resultbox = renderresult.Find("#p_success3");

            input_jobtitle.Change(Guid.NewGuid().ToString());

            await button3.ClickAsync(new Microsoft.AspNetCore.Components.Web.MouseEventArgs());

            Assert.Equal("New building added", resultbox.TextContent);

        }
    }
}
