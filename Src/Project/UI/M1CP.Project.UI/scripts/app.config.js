(function () {
    'use strict';
    /*angular.module("m1cp").config(["$httpProvider", function ($httpProvider) {
        $httpProvider.responseInterceptors.push('httpInterceptor');
      
        function showSpinner (data, headersGetter) {
            angular.element('#loader-container').show();
            return data;
         };

         $httpProvider.defaults.transformRequest.push(showSpinner);
        
    }]).factory('httpInterceptor',["$q","$window", function ($q, $window) {
        return function (promise) {
            return promise.then(function (response) {
               angular.element('#loader-container').hide();
                return response;

            }, function (response) {
                angular.element('#loader-container').hide();
                return $q.reject(response);
            });
        };
    }]);*/

    function loaderIcon($http) {
        return {
            restrict: 'A',
            link: function (scope, elem) {
                scope.isLoading = isLoading;
                scope.$watch(scope.isLoading, toggleLoader);
               
                function toggleLoader(loading) {
                    if (loading) {
                        elem.show();
                    } else {
                       elem.hide();
                    }
                }

                function isLoading() {
                    return $http.pendingRequests.length > 0;
                }
            }
        };
    }

    loaderIcon.$inject = ['$http'];
    angular.module("m1cp").directive('loaderIcon', loaderIcon);
    
})();
