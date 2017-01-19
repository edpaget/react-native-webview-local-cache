
# react-native-web-view-local-cache

## Getting started

`$ npm install react-native-web-view-local-cache --save`

### Mostly automatic installation

`$ react-native link react-native-web-view-local-cache`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-web-view-local-cache` and add `RNWebViewLocalCache.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNWebViewLocalCache.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNWebViewLocalCachePackage;` to the imports at the top of the file
  - Add `new RNWebViewLocalCachePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-web-view-local-cache'
  	project(':react-native-web-view-local-cache').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-web-view-local-cache/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-web-view-local-cache')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNWebViewLocalCache.sln` in `node_modules/react-native-web-view-local-cache/windows/RNWebViewLocalCache.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Cl.Json.RNWebViewLocalCache;` to the usings at the top of the file
  - Add `new RNWebViewLocalCachePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNWebViewLocalCache from 'react-native-web-view-local-cache';

// TODO: What do with the module?
RNWebViewLocalCache;
```
  