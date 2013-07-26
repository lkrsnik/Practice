<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Problem5</title>
</head>
<body>
    <div>
        <b>Naloga5:</b><br />
        <%: ViewData["result"] %><br />
        <br />
        <%= Html.ActionLink("Back","Index") %><br />
    </div>
</body>
</html>
