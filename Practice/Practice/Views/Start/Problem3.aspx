﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Problem3</title>
</head>
<body>
    <div>
        <b>Naloga3:</b><br />
        <%: ViewData["result"] %><br />
        <br />
        <%= Html.ActionLink("Back","Index") %><br />
        

    </div>
</body>
</html>
