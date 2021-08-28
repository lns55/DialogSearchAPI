using iMessengerCoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DialogSearchAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly IEnumerable<RGDialogsClients> _data;

        public SearchController(IEnumerable<RGDialogsClients> data)
        {
            _data = data;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Guid), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public ActionResult<Guid> Post(ICollection<Guid> clientId)
        {
            var dialogSearch = _data
               .GroupBy(x => x.IDRGDialog)
               .Where(x => x.All(x => clientId.Contains(x.IDClient))
                           && x.Count() == clientId.Count)
               .Select(x => x.Key)
               .SingleOrDefault();

            return dialogSearch != default
                ? Ok(dialogSearch)
                : NotFound();
        }
    }
}

