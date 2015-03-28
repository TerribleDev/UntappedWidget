[![Build status](https://ci.appveyor.com/api/projects/status/3pocqbscj75t4nif/branch/master?svg=true)](https://ci.appveyor.com/project/tparnell8/untappedwidget/branch/master)

This provides a simple embeddable widget for your [Untappd](https://untappd.com) profile. Server portions [hosted on azure](http://untappdwidget.azurewebsites.net/)

## How do I use this?

Simply add the css and js files at the root of this project to your website. Then call:

We host the css at `http://untappdwidget.azurewebsites.net/Content/jquery.UntappedWidget.min.css`
We host the js at `http://untappdwidget.azurewebsites.net/Scripts/jquery.UntappedWidget.min.js`
`$("#Target").untappd("YourUsername");`

## How do I contribute?

Submit pull requests

## Todo

* Make a build time minifier
* Push to Bower?
* Move the css/js into a cdn of some kind?
