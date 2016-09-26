(function () {
    var myApp = angular.module("MyApp", [])
     .controller("indexController", IndexController)
    IndexController.$inject = ["$scope"];
    function IndexController($scope) {
        var vm = this;
        vm.$scope = $scope;
        vm.test = "Angular is working";
    }
}());