window.onscroll = function () { scrollFunction() };

function scrollFunc() {
    // Set a variable for our button element.
    const scrollToTopButton = document.getElementById('js-top');

    if (scrollToTopButton != null)
    {
        // Get the current scroll value
        let y = document.body.scrollTop;
        //let y = window.scrollY;

        // If the scroll value is greater than the window height, let's add a class to the scroll-to-top button to show it!
        if (y > 0) {
            //scrollToTopButton.style.display = "inline-flex;";
            scrollToTopButton.className = "top-link show";
        }
        else {
            //scrollToTopButton.style.display = "none";
            scrollToTopButton.className = "top-link hide";
        }
	}
}

function scrollFunction() {
    const scrollToTopButton = document.getElementById('js-top');

    if (scrollToTopButton != null)
    {
        if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
            //scrollToTopButton.style.display = "inline-flex;";
            scrollToTopButton.className = "top-link show";
        } else {
            //scrollToTopButton.style.display = "none";
            scrollToTopButton.className = "top-link hide";
        }
	}

    
}

// When the user clicks the button, the page scrolls to the top
function OnScrollEvent() {
    document.documentElement.scrollTop = 0;
}