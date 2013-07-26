<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    <script src="../../Scripts/jquery-1.7.1.js"></script>
    <script>
        $(document).ready(function () {
            $("p").hide();
            $("button").click(function () {
                $("p").fadeToggle();
            });
        });
    </script>
</head>
<body>
    <div>
        <button>No idea what to do??</button><br />
        <p><b>What do you want?!?</b><br />
        <%= Html.ActionLink("a) Solve problem 3","Problem3") %><br />
        <%= Html.ActionLink("b) Solve problem 4","Problem4") %><br />
        <%= Html.ActionLink("c) Solve problem 5","Problem5") %><br />
        <%= Html.ActionLink("d) Solve problem 6","Problem6") %><br />
        <%= Html.ActionLink("e) Solve problem 8","Problem8") %><br />
        <%= Html.ActionLink("f) Solve problem 9","Problem9") %><br />
        <%= Html.ActionLink("f) Solve problem 11","Problem11") %></p>
    </div>
</body>
</html>
