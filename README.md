# ASPNETWebStack
fork from https://archive.codeplex.com/?p=aspnetwebstack


ASP.NET is a free web framework for building great web sites and applications.

This site is the home of the ASP.NET MVC, Web API, and Web Pages source code. If you want to use the released versions of these products to develop your applications, visit http://www.asp.net to find official installers, documentation, tutorials, samples, and videos.

These products are actively developed by the ASP.NET team assigned to the Microsoft Open Tech Hub and in collaboration with a community of open source developers. Together we are dedicated to creating the best possible platform for web development.

**Note: The Web API OData project has been moved to GitHub. You can find the latest source and issues at https://github.com/odata/webapi.**

## Source Code
You can browse the source code via the web or use git to clone the source repository.

  git clone https://github.com/Allen-Wei/ASPNETWebStack.git

To build and run the tests from a command prompt, run build.cmd (found in the root directory). Note: As part of building you may need to obtain NuGet packages from the Outercurve Foundation NuGet public feed*.
build

* By running build, you will be initiating the download of other software packages from a NuGet-based feed that is owned by the Outercurve Foundation. You are responsible for locating, reading and complying with the license terms that accompany each such package. Each package is licensed to you by its owner. Microsoft is not responsible for, nor does it grant any licenses to, third-party packages.
See Runtime.sln in the root directory to open the solution in Visual Studio.

Signed Nightly Builds

If you do not want to build the source, nightly builds are available via a private NuGet feed. Nightly builds are meant for developers to try out new features or bug fixes ahead of an official prerelease or final build. We strongly urge you to only use official builds for production.

Nightly builds can be used with Visual Studio 2010 SP1 or Visual Studio 2012. To use the nightly build:
In your Package Manager settings add the following package source: https://www.myget.org/F/aspnetwebstacknightly/ 
Add or update to the latest build of ASP.NET. The nightly build is labeled (nightly YYYY MMM DD). 
See the nightly build documentation for more information.

## Contribute
There are lots of ways to contribute to the project, and we appreciate our contributors.
You can contribute by reviewing and sending feedback on code checkins, suggesting and trying out new features as they are implemented, submit bugs and help us verify fixes as they are checked in, as well as submit code fixes or code contributions of your own. Note that all code submissions will be rigorously reviewed and tested by the ASP.NET Team, and only those that meet an extremely high bar for both quality and design/roadmap appropriateness will be merged into the source.

## Roadmap
Current RTM versions are MVC 5.2.2, Web API 2.2.2 and Web Pages 3.2.2. The current preview version is MVC 5.2.3, Web API 2.2.3 and Web Pages 3.2.3. We expect to release the RTM bits in next few weeks to nuget.org and later in Visual Studio 2015.
We are now working on MVC 6 which combines the three frameworks into a unified framework. You can find the project on GitHub at https://github.com/aspnet/Mvc and https://github.com/aspnet/Razor.
We are tracking issues for future versions of MVC 5.X, Web API 2.X and Web Pages 3.X in the Issue Tracker here. The work for MVC 6 is tracked only on GitHub.
