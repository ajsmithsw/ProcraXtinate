# ProcraXtinate
On big Xamarin projects, the build times can be painful. Install this extension on Visual Studio for Mac, and you'll always have something interesting to do to pass the time :)

## Installing
Download the .mpack file from the repository. In VS for Mac, go to Extensions and select 'Install from file':

![Extensions](/images/extensions.png) ![Install](/images/install.png)

## Building
Use the **mdtool** (often located in */Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool*) to create a .mpack file from the compiled .dll:

```BASH
$ mdtool setup pack someAddin.dll
```

## Contributing
By all means, go for it - Fork this repository and raise a PR!