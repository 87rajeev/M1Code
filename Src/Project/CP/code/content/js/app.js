var m1app = angular.module("m1app", ["ngSanitize", "ui.bootstrap"]);

m1app.filter('html', ['$sce', function ($sce) {
    return function (text) {
        return $sce.trustAsHtml(text);
    };
}]);

m1app.controller('headerController', function ($scope, $timeout, $window) {
    angular.element($window).bind("scroll", function () {
        if ($(window).scrollTop() > 50) {
            $(".navbar-default").addClass("active");
        } else {
            //remove the background property so it comes transparent again (defined in your css)
            $(".navbar-default").removeClass("active");
        }

    });
});


//scroll to top animation using angularJS. Pass value in milliseconds in html to set time taken (timeTaken) to scroll to top of page
m1app.controller('footerController', function ($scope, $timeout, $window) {
    $scope.scrollToTop = function(timeTaken) {
        $('html').animate({
            scrollTop: 0
        }, timeTaken);
    };

});

m1app.directive("backgroundImg", function ($timeout) {
  
        return {
            restrict: 'A',
            link: function(scope, elem, attrs) {
                elem.css({
                    'background': 'url(' + attrs.backgroundImg + ') no-repeat',
                    'background-size': 'cover'
                });
            }
        }
   
});

m1app.directive("carouselComponent", function ($timeout) {
    return {

        restrict: "A",

        scope: {


        }, controller: function ($element) {

        },
        link: function (scope, element, attrs) {
            var minItem = parseInt(attrs.minitem);
            var maxItem = parseInt(attrs.maxitem);
			var centerPadding =(attrs.centerpadding);
            var speed = parseInt(attrs.speed);
            var autoplay = JSON.parse(attrs.autoplay);
            var infinite = JSON.parse(attrs.infinite);
            var autoplaySpeed = parseInt(attrs.autoplayspeed);
            var queryResult = element[0].querySelector('.slider');
            var wrappedQueryResult = angular.element(queryResult);

            $timeout(function () {
                element.slick({
                    speed: speed,
                    autoplay: autoplay,
                    infinite: infinite,
                    autoplaySpeed: autoplaySpeed,
                    centerMode: false,
                    centerPadding: '20px',
                    slidesToShow: maxItem,
                    slidesToScroll: maxItem,
                    arrows: true,
                    dots: true,
                    draggable: false,
                    focusOnSelect: false,
                    pauseOnFocus: false,
                    pauseOnHover: false,
                    mobilefirst: true,
                    prevArrow: "<img class='a-left control-c prev slick-prev' src='../../images/Carousel-ArrowLeft-icon-1x.png'>",
                    nextArrow: "<img class='a-right control-c next slick-next' src='../../images/Carousel-ArrowRight-icon-1x.png'>",

                    responsive: [
                     {
                         breakpoint: 1204,
                         settings: {
                             autoplay: false,
                             infinite: true,
                             arrows: false,
                             dots: true,
                             centerMode: true,
                             slidesToShow: 3,
							 centerPadding: centerPadding,
                         }
                     },
                     {
                         breakpoint: 768,
                         settings: {
                             autoplay: false,
                             infinite: true,
                             arrows: false,
                             dots: true,
                             centerMode: true,
							 centerPadding: centerPadding,
                             slidesToShow: minItem > 1 ? 2 : 1,
                             initialSlide: minItem > 1 ? 1 : 0,
                         }
                     }
                 ]

                });
            }, 1);


            element.on('beforeChange', function (event, slick, currentSlide, nextSlide) {
                var currentSlide = currentSlide / maxItem;
                var nextSlide = nextSlide / maxItem;
                slick.$dots.children().children().html('');
                var direction = nextSlide > currentSlide ? 1 : 0;
                var indicator_c = direction ? 'next' : 'prev';
                $current_dot = slick.$dots.children().children().eq(currentSlide);
                $current_dot.html('<div class="dot-indicator ' + indicator_c + '">');
                setTimeout(function () {
                    $current_dot.html('');
                }, 200);
            });
        },
        controllerAs: 'ctrl'
    }
});