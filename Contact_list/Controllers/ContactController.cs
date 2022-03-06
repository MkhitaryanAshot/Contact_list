using Microsoft.AspNetCore.Mvc;
using Contact_list.Domain.Entities;
using Contact_list.DAL.Interfaces;
using AutoMapper;
using Contact_list.Models;

namespace Contact_list.Controllers
{
    public class ContactController : Controller
    {
       private readonly IContactsRepository _contactsRepository;

        private readonly IMapper _mapper;
        public ContactController(IContactsRepository repo,IMapper mapp)
        {
            _contactsRepository = repo;
            _mapper = mapp;
        }
        public IActionResult Index()
        {
            var contacts = _contactsRepository.Get();
            var contactViewModels = _mapper.Map<IEnumerable<ContactViewModel>>(contacts);
            return View(contactViewModels);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactViewModel cont)
        {
            var contact = _mapper.Map<Contact>(cont);
            await _contactsRepository.CreateAsync(contact);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _contactsRepository.RemoveAsync(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(ContactViewModel cont)
        {
            var contact = _mapper.Map<Contact>(cont);
            await _contactsRepository.EditAsync(contact);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public  async Task<IActionResult> Update(int id)
        {
            var contact = await _contactsRepository.GetById(id);
            var contactViewModel = _mapper.Map<ContactViewModel>(contact);
            return View(contactViewModel);
        }

        
        [HttpGet]
        public async Task<IActionResult> SingleContact(int id)
        {
            var contact = await _contactsRepository.GetById(id);
            var contactViewModel = _mapper.Map<ContactViewModel>(contact);
            return View(contactViewModel);
        }



    }
}
