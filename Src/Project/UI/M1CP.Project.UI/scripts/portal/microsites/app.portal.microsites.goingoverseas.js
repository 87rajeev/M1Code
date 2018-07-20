(function () {
    'use strict';

    //Angular Controller Definition Reference1 and Dependency Should be Injected in Array Notation
    /* angular.module("m1cp.portal.microsites").controller("ContactusController1",["$scope", function ($scope) {
    }]);

    //Angular Controller Definition Reference2 and Dependency Should be Injected Using $inject
    angular.module("m1cp.portal.microsites").controller("ContactusController2", ContactusController2);
    ContactusController2.$inject = ['formService'];
    function ContactusController2(formService) {
        var vm = this;
        vm.footerlinks = formService.getFooters();
        vm.getfooters = getfooters;
        vm.setfooters = setfooters;

        function getfooters() {

        }

        function setfooters() {

        }
    }

    //Angular Directive Definition Reference and Dependency Should be Injected 
    angular.module("m1cp.portal.microsites").directive("userInformation", function ($scope) {
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
    }

    //Angular Service Definition Using Service Method
    angular.module("m1cp.portal.microsites").service("userinfo1", function () {
        this.value = "";
        this.getuser = function () {

        }
        this.saveuser = function () {

        }
    });

    //Angular Service Definition Using Factory Method1
    angular.module("m1cp.portal.microsites").factory("userinfo2", ["$http", "$interval", function ($http, $interval) {
        var value = "";
        var service = {
            value: value,
            getuser: getuser,
            saveuser: saveuser
        }
        return service;

        function getuser() {

        }

        function saveuser() {

        }
    }]);

    //Angular Service Definition Using Factory Method2
    angular.module("m1cp.portal.microsites").factory("userinfo3", userinfo);
    userinfo.$inject = ["$http", "$interval"];

    function userinfo() {
        var value = "";
        var service = {
            value: value,
            getuser: getuser,
            saveuser: saveuser
        }
        return service;

        function getuser() {

        }

        function saveuser() {

        }
    };

    //Angular Filter Definition Reference 
    angular.module("m1cp.portal.microsites").filter('html', ['$sce', function ($sce) {
        return function (text) {
            return $sce.trustAsHtml(text);
        };
    }]);*/

	
    angular.module("m1cp.portal.microsites").controller('overseasController',[ "$scope", "$timeout", "$window", function ($scope, $timeout, $window) {

		
		  $scope.changeFilterOption = function(obj) {
				var currentobject=obj.split(':');
				var value=currentobject[0];
				$scope.url="//"+currentobject[1];
				/*var el =angular.element('.redirect-btn');
				el.attr('href', url);
				*/
		  };
}]);

})();
