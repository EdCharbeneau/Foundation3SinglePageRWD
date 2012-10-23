﻿/****** Installation Instructions ******

1. Update the Layout

Open the /Views/_ViewStart.cshtml
Change the Layout to _Foundation.cshtml like the example below:

@{
    //This is the default MVC template
    //Layout = "~/Views/Shared/_Layout.cshtml";
    
    //This is the Foundation MVC template
    Layout = "~/Views/Shared/_Foundation.cshtml";
}

2. Remove the default theme

Once the ViewStart has been updated. Replace the default Index.cshtml:

Rename ~/Views/Home/Index.cshtml to Index.cshtml.exclude (or delete the file)
Rename ~/Views/Home/Foundation_Index.cshtml to Index.cshtml

Replace the default style:

Rename ~/Content/Site.css to Site.css.exclude (or delete the file)

3. Automatic Bundling and Minification

Open the /App_Start/BundleConfig.cs
Add the following bundles:

      #region Foundation Bundles
      bundles.Add(new StyleBundle("~/Content/foundation/css").Include(
                 "~/Content/foundation/foundation.css",
                 "~/Content/foundation/app.css"));

      bundles.Add(new ScriptBundle("~/bundles/foundation").Include(
                "~/Scripts/foundation/jquery.*",
                "~/Scripts/foundation/app.js"));
      #endregion

4.

You are now ready to begin building your MVC project using Foundation.

/****** Related Nuget packages ******
Want to rapid prototype and wire frame directly from code using Html Helpers? 
Try the prototyping package on nuget. It works great with Foundation.
http://www.nuget.org/packages/Prototyping_MVC

Having trouble with media queries? Debug them with this simple CSS file.
http://nuget.org/packages/CSS_Media_Query_Debugger

/****** Documentation ******
Docs http://foundation.zurb.com/docs/
Demo http://edcharbeneau.github.com/FoundationSinglePageRWD/

Articles:
Responsive design using Foundation with asp.net MVC http://www.simple-talk.com/dotnet/asp.net/responsive-design-using-foundation-with-asp.net-mvc/
Prototyping Article http://www.simple-talk.com/dotnet/asp.net/rapid-prototyping,-the-mvc-working-model/

Presentations:
A Crashcourse in Responsive Design http://www.slideshare.net/edcharbeneauii/a-crash-course-in-responsive-design-12007229
Don't be a stereotype rapid prototype http://www.slideshare.net/edcharbeneauii/dont-be-a-stereotype-rapid-prototype

Follow us:
Ed Charbeneau http://twitter.com/#!/edcharbeneau
Foundation Zurb http://twitter.com/#!/foundationzurb

Change Log:

Version 1.0.311
Initial NuGet Release

Note: version scheme <major>.<minor>.<foundation version>
foundation version represents the foundation version less the "." for example 2.1.4 would be #.#.214

Foundation Framework Support:
http://foundation.zurb.com/docs/support.php