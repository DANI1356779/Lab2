using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        //Muestra interfaz
        public ActionResult Create()
        {
            return View();
        }

        //Procesa datos
        [HttpPost]
        public ActionResult Create(int idVideo, string titulo, int repro, string url)
        {
            //Guardar en la base los datos
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("sp_video_insertar",
                                         CommandType.StoredProcedure,
                                         parametros);
            RedirectToAction("Index", "Video");
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Edit(int idVideo);
        public ActionResult Update(int IdVideo,
                                   string titulo,
                                   int reproduccion,
                                   string Url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproduccion", reproduccion));
            parametros.Add(new SqlParameter("@Url", Url));

            BaseHelper.ejecutarSentencia("sp_video_update", CommandType.StoredProcedure, parametros);

            return View("Video");
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", idVideo));
            BaseHelper.ejecutarSentencia("sp_video_Delete", CommandType.StoredProcedure, parametros);

            return View("Video");
        }

    }
}
