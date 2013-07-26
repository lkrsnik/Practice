<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Problem4</title>

</head>
<body>
    <div>
        <b>Naloga4:</b><br />
        <%: ViewData["result"] %><br />
        x: <%: ViewData["x"] %><br />
        y: <%: ViewData["y"] %><br />
        <br />
        <%= Html.ActionLink("Back","Index") %><br />
    </div>
</body>
</html>
