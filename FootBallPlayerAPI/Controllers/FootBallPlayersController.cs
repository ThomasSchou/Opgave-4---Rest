using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootBallPlayerAPI.Items;
using FootBallPlayerAPI.Managers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;

namespace FootBallPlayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootBallPlayersController : ControllerBase
    {

        public FootBallPlayerManager _manager = new FootBallPlayerManager();

        [HttpGet()]
        public List<FootBallPlayer> Get()
        {
            return _manager.GetAllPlayers();
        }

        [HttpGet("{id}")]
        public FootBallPlayer Get(int id)
        {
            return _manager.GetPlayerByID(id);
        }

        [HttpPost]
        public FootBallPlayer Post([FromBody] FootBallPlayer value)
        {
            return _manager.AddPlayer(value);
        }

        [HttpPut("{id}")]
        public FootBallPlayer Put(int id, [FromBody] FootBallPlayer value)
        {
            return _manager.UpdateItem(id, value);
        }

        [HttpDelete("{id}")]
        public FootBallPlayer Delete(int id)
        {
            return _manager.DeletePlayer(id);
        }
    }
}
