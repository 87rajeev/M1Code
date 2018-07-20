(function () {
    'use strict';
    //Angular Directive Definition Reference and Dependency Should be Injected 
    /*angular.module("m1cp.core").directive("userInformation", function ($scope) {
        return {
            templateUrl: "userinfo.html",
            restrict: "EA",
            scope: {
                name: "@",
                max: "=",
                updateUser: "&"
            },
            link: function (scope, element, attrs) {

            },
            controller: userInfoController,
            controllerAs: "vm",
            bindToController: true
        }
    });


    userInfoController.$inject = ['$scope'];
    function userInfoController($scope) {
        var vm = this;
        vm.min = 3;
        vm.$onInit = onInit;
        function onInit() {
            console.log('$scope.vm.min = ', $scope.vm.min);
            console.log('$scope.vm.max = ', $scope.vm.max);
            console.log('vm.min = ', vm.min);
            console.log('vm.max = ', vm.max);
        }
    }*/
})();
