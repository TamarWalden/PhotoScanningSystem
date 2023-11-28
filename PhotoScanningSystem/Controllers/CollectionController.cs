using Common.DTO_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace PhotoScanningSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionController : ControllerBase
    {
        readonly ICollectionService collectionService;
        public CollectionController(ICollectionService service)
        {
            collectionService = service;
        }


        [HttpGet]
        [Route("GetCollection/{id}")]
        public async Task<CollectionDTO> GetById(string id)
        {
            var collection= await collectionService.GetCollection(id);
            return collection;
        }

        //[HttpPost]
        //[Route("SaveImeges/{images}")]
        //public async Task<List<ImageDTO>> SaveImeges()
        //{

        //}
    }
}
