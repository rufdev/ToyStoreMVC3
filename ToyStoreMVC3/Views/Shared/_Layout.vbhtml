<!DOCTYPE html>
<html>
<head>
    <title>@ViewData("Title")</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
</head>

<body>
    <div class="page">

        <div id="header">
            <div id="title">
                <h1>My MVC Application at http://pinoy-brownbag.blogspot.com/ </h1>
            </div>

            <div id="logindisplay">
                @Html.Partial("_LogOnPartial")
            </div>

            <div id="menucontainer">

                <ul id="menu">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                </ul>

            </div>
        </div>

        <div id="main">
            @RenderBody()
            <div id="footer">
            <a target="_blank" href="http://feeds.feedburner.com/~r/ProgrammingBrownBagSessions/~6/1"><img src="http://feeds.feedburner.com/ProgrammingBrownBagSessions.1.gif" alt="Random Brown Bag Sessions" style="border:0"></a>&nbsp; &nbsp; &nbsp;<a href="http://twitter.com/aguilarufino"><img src="http://www.twitterbutton.com/images/buttons/button_new01a.gif" height="100px" title="aguilarufino" /></a>
            </div>
        </div>
    </div>
</body>
</html>
