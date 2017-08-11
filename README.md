# ProcraXtinate
On big Xamarin projects, the build times can be painful. Install this extension on Visual Studio for Mac, and you'll always have something interesting to do to pass the time :)

## Installing
Download the .mpack file from the repository. In VS for Mac, go to Extensions and select 'Install from file':

![Extensions](/images/extensions.png) ![Install](/images/install.png)

## Usage
Once the package is installed, you can use the extension by selecting ```Run > Fun Run``` from the menu - A random website will open in your default browser whilst your app builds and then runs!

Set a key binding on the ProcraXtinate control to create a keyboard shortcut for the behaviour. Then enjoy :)

## Building
Use the **mdtool** (often located in */Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool*) to create a .mpack file from the compiled .dll:

```BASH
$ mdtool setup pack someAddin.dll
```

## Contributing
By all means, go for it - Fork this repository and raise a PR!

## Resources
* http://www.monodevelop.com/developers/articles/creating-a-simple-add-in/
* http://www.monodevelop.com/developers/articles/publishing-an-addin/