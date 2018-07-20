        /*Start of animation for A4 sliding top to bottom*/
        var $animation_elements = $('.animation-element');
        var $window = $(window);

        function view_port() {
          var window_height = $window.height();
          var window_top_position = $window.scrollTop();
          var window_bottom_position = (window_top_position + window_height);
         
          $.each($animation_elements, function() {
            var $element = $(this);
            var element_height = $element.outerHeight();
            var element_top_position = $element.offset().top;
            var element_bottom_position = (element_top_position + element_height);
         
            //check to see if this current container is within viewport
            if ((element_bottom_position >= window_top_position) &&
                (element_top_position <= window_bottom_position)) {
              $element.addClass('in-view');
            } else {
              $element.removeClass('in-view');
            }
          });
        }

        $window.on('scroll resize', view_port);
        $window.trigger('scroll');
        /*End of animation for A4 sliding top to bottom*/