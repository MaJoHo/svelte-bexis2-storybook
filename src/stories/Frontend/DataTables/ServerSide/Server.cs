using BExIS.Security.Entities.Subjects;
using BExIS.Security.Services.Subjects;
using BExIS.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.Mvc;


namespace BExIS.Web.Shell.Controllers
{
    public class UiTestController : Controller
    {
        #region datatables
        [HttpPost]
        public ActionResult Load(DataTableRecieverModel model)
        {
            using (UserManager userManager = new UserManager())
            {
                try
                {
                    int skip = model.Start;

                    IQueryable<User> data = null;

                    data = userManager.Users.AsQueryable();

                    //search
                    if (!string.IsNullOrEmpty(model.Search.Value))
                    {
                        string searchValue = model.Search.Value.ToLower();
                        data = data.Where(i =>
                            (i.Name != null && i.Name.ToLower().Contains(searchValue)) ||
                            (i.DisplayName != null && i.DisplayName.ToLower().Contains(searchValue)) ||
                            (i.Email != null && i.Email.ToLower().Contains(searchValue)));
                    }

                    int filteredRows = data.ToList().Count();

                    //order by
                    var sorting = string.Join(",", model.Order.Select(o => model.Columns[o.Column].Data + " " + o.Dir));
                    if (!string.IsNullOrEmpty(sorting))
                    {
                        data = data.OrderBy(sorting);
                    }

                    //paging
                    data = data.Skip(skip).Take(model.Length);

                    int countAll = userManager.Users.Count();

                    List<UserModel> tmp = new List<UserModel>();
                    data.ToList().ForEach(u=> tmp.Add(new UserModel(u)));

                    DataTableSendModel sendModel = new DataTableSendModel();
                    sendModel.data = tmp;
                    sendModel.draw = model.Draw;
                    sendModel.recordsTotal = countAll;
                    sendModel.recordsFiltered = filteredRows;

                    return Json(sendModel);
                }
                catch (Exception exception)
                {
                    string json = "{\"error\":\"" + exception.Message + "\"}";

                    return Json(json);
                }
            }
        }

        #endregion

    }

    public class UserModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public UserModel(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Email = user.Email;
        }
    }
}
