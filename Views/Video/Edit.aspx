<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Edit</title>
</head>
<body>
  <form action="/Video/Update" method="post">
    <fieldset>

    <legend>Introduzca los datos del video a modificar:</legend>
    <label for="IdVideo">ID del video</label>
    <input type="text" name="IdVideo" />

    <label for="titulo">Titulo del video</label>
    <input type="text" name="titulo"/>

    <label for="reproduccion">reproducciones</label>
    <input type="text" name="reproduccion" />

    <label for="Url">Url del video</label>
    <input type="text" name="Url"/>

    <label for="IdVideo">ID del video a modificar</label>
    <input type="text" name="IdVideo" />

    <input type="submit" value="Modificar Video"/>
</body>
</html>
