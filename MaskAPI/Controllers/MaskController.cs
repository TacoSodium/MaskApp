using System.Collections.Generic;
using MaskAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaskAPI.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class MaskController : ControllerBase
    {
        public static List<Mask> MasksInStock = new List<Mask>();

        public MaskController() {
            MasksInStock.Add(new Mask("m-999", 1, "Black", true, false, "Spots", true, 30.00));
            MasksInStock.Add(new Mask("m-456", 2, "Blue", false, true, "Swirls", false, 1.00));
            MasksInStock.Add(new Mask("m-900", 3, "Purple", false, false, "Flowers", true, 15.00));
        }

        [HttpGet("GetAll")]
        public List<Mask> GetAll() {
            return MasksInStock;
        }

        [HttpGet("{maskID}")]
        public Mask GetMask(string maskID) {
            Mask found = null;
            foreach (Mask mask in MasksInStock) {
                if (maskID == mask.MaskID) {
                    found = mask;
                    break;
                }
            }
            return found;
        }
    }
}