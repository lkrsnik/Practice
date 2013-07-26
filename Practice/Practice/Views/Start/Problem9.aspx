<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Problem9</title>
</head>
<body>
    <div>
        <b>Naloga9:</b><br />
        <%: ViewData["result"] %><br />
        <%: ViewData["a"] %><br />
        <%: ViewData["b"] %><br />
        <%: ViewData["c"] %><br />
        <br />
        <%= Html.ActionLink("Back","Index") %><br />
    </div>
</body>
</html>
