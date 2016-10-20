# Third Party Analytics Component

After hearing stories from Sitecore users and developers about the struggles they dealt with trying to manage third party tracking IDs (such as those used by Google Analytics) between environments and sites, and experiencing the headaches in my own development the creation of this control was born.

These required third party tracking values usually are injected in one of two ways. The first method commonly used is to place the tracking code directly on the main layout. This is easy as it ensures the tracking code shows for all pages and only loads once. The downfall is as source code migrates through environments or additional the organization grows and additional sites are added into Sitecore the management of proper tracking IDs become a developer challenge to maintain.

The second commonly employed method is the usage of a configuration file. A component is developed or code is placed directly in the main layout that reads the required ID values and even possibly some form of JavaScript snippets that are injected at page load. This method is a step in the right direction, but still requires the development team to be fully aware of the correct IDs for the environment and site. [This use to be my preferred method until I woke-up realizing there was a better way, which now sits in-front of you.]

## Short Description
Sitecore MVC component that allows for the management of Google Analytics and other third party tracking products to be managed from the Sitecore content tree.

## Solution Requirements
* Visual Studio 2015
* .NET 4.5.2
* [Access to the Sitecore NuGet feed](https://doc.sitecore.net/sitecore_experience_platform/developing/developing_with_sitecore/sitecore_public_nuget_packages_faq), https://doc.sitecore.net/sitecore_experience_platform/developing/developing_with_sitecore/sitecore_public_nuget_packages_faq
* Optional Team Development For Sitecore (TDS)
* Default build is targeting Sitecore 8.2 Initial Release (rev. 160729)
* Sitecore site built on MVC

## What's Included
* TDS project for Sitecore artifact syncing
* Full source code to allow for extension with other third party applications
* Sitecore package as found in _Documents folder
    * If you are running Sitecore 7.2, 7.5, 8.0, or 8.1 install the Sitecore package 'Paragon.Sitecore.ThirdPartyAnalytics_8.0.zip'
    * If you are running Sitecore 8.2+ install the 'Paragon.Sitecore.ThirdPartyAnalytics_8.2.zip'

### Sitecore Artifacts
When either installing from the package or syncing from TDS the following items will be added to your Sitecore content tree.
* Template named 'ThirdPartyAnalytics'
    * Found at /sitecore/templates/Modules/ThirdPartyAnalytics/Anayltics/ThirdPartyAnalytics
* View Rendering named 'ThirdPartyAnalytics'
    * Found at /sitecore/layout/Renderings/Modules/ThirdPartyAnalytics/Analytics/ThirdPartyAnalytics
* Placeholder Setting named 'headplaceholder'
    * Found at /sitecore/layout/Placeholder Settings/ThirdPartyAnalytics/headplaceholder

### File System
The deployment involves two file for the file system.
* Paragon.Sitecore.ThirdPartyAnalytics.dll
    * created in the web root BIN directory
* ThirdPartyAnalytics.cshtml
    * created at < webroot >/Views/Analytics/ThirdPartyAnalytics/ThirdPartyAnalytics.cshtml

## How to Use
1. Install the included Sitecore package or sync via TDS
2. Add the new view rendering 'ThirdPartyAnalytics' to one or more placeholder settings
3. Create an item based on 'ThirdPartyAnalytics' template
4. Add the 'ThirdPartyAnalytics' view to one or more pages and/or template standard values and associate to the proper data source as created in step 3


## Licensed Under
MIT License

Copyright (c) 2016 Scott Gillis

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
