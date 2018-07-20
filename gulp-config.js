module.exports = function () {
    var instanceRoot = "D:\\inetpub\\wwwroot\\m1\\Website";
    var config = {
        websiteRoot: instanceRoot + "\\Website",
        sitecoreLibraries: instanceRoot + "\\Website\\bin",
        licensePath: instanceRoot + "\\Data\\license.xml",
        solutionName: "M1.CP.sln",
        buildConfiguration: "Debug",
        buildToolsVersion: 'auto',
        buildMaxCpuCount: 0,
        buildVerbosity: "minimal",
        buildPlatform: "Any CPU",
        publishPlatform: "AnyCpu",
        runCleanBuilds: false
    };
    return config;
}
