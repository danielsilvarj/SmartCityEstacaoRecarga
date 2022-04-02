using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartCity.Aplicacao;
using SmartCity.Dominio.Entidades;
using SmartCity.Infra.Dados.Config;
using SmartCity.MVC.Models;

namespace SmartCity.MVC.Controllers
{
    public class EstacaoRecargaController : Controller
    {
        private readonly IEstacaoRecargaApp _estacaoRecargaApp;

        public EstacaoRecargaController(IEstacaoRecargaApp estacaoRecargaApp)
        {
            _estacaoRecargaApp = estacaoRecargaApp;
            //_mapper = mapper;

        }

        // GET: EstacaoRecarga
        public ActionResult Index()
        
        {
            return View(_estacaoRecargaApp.Listar());
        }

        // GET: EstacaoRecarga/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // GET: EstacaoRecarga/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstacaoRecarga/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                estacaoRecarga.Id = Guid.NewGuid();
                _estacaoRecargaApp.Adicionar(estacaoRecarga);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: EstacaoRecarga/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // POST: EstacaoRecarga/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                // TODO: Add update logic here
                _estacaoRecargaApp.Atualizar(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstacaoRecarga/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // POST: EstacaoRecarga/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                // TODO: Add delete logic here
                _estacaoRecargaApp.Excluir(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
