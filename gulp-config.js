module.exports = function () {
    var instanceRoot = "C:\Repos\Helix-Example\SandBox";
  var config = {
    websiteRoot: instanceRoot + "\\Website",
    sitecoreLibraries: instanceRoot + "\\Website\\bin",
    licensePath: instanceRoot + "\\Data\\license.xml",
    solutionName: "Habitat",
    buildConfiguration: "Debug",
    runCleanBuilds: false
  };
  return config;
}