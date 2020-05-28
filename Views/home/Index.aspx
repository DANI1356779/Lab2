<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Pagina Principal</title>
</head>
<body>
   <h2>Menu de opciones:</h2>
    <br />
    <a href="/Video/Create">Agregar video</a>
    <br />
     <a href="/Video/Edit">Modificar video</a>
    <br />
      <a href="/Video/Delete">Eliminar</a>
    <br />
       <a href="/Video/Index">Consultar todos los videos</a>
    <br />
</body>
</html>
 