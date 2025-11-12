// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

(() => {
    document.addEventListener('DOMContentLoaded', () => {

        // ハンバーガーアイコン

        (() => {
            const menuBtn = document.querySelector(".menuBtn");
            const overlayBox = document.querySelector(".overlayNav");
            const menuLine = document.querySelector(".menuLine");

            menuBtn.addEventListener("click", () => {
                overlayBox.classList.toggle("show");
                menuLine.classList.toggle("active");

            });

        })();


    });
  

    // カルーセル
    (() => {
        const carousel = document.querySelector('.carousel');
        const imageContainer = carousel.querySelector('.imgBox');
        const images = Array.from(imageContainer.querySelectorAll('img'));
        const prevButton = carousel.querySelector('.prev');
        const nextButton = carousel.querySelector('.next');
        const indicator = carousel.querySelector('.indicator');
        const indicatorItems = [];
        let current = 0;


        function prev() {
            let target = current - 1;
            if (target < 0) {
                target = images.length - 1;
            }
            to(target);
        }

        function next() {
            let target = current + 1;
            if (target >= images.length) {
                target = 0;
            }
            to(target);
        }

        function to(target) {
            imageContainer.style.transform = `translateX(${target * -80}%)`;
            current = target;

            indicatorItems.forEach((item, index) => {
                if (index === target) {
                    item.classList.add('current');
                } else {
                    item.classList.remove('current');
                }
            })

            auto();
        }

        prevButton.addEventListener('click', prev);
        nextButton.addEventListener('click', next);

        images.forEach((image, index) => {
            const li = document.createElement('li');
            if (index === 0) {
                li.classList.add('current');
            }
            indicator.appendChild(li);

            indicatorItems.push(li);

            li.addEventListener('click', () => {
                to(index);
            })
        });

        // カルーセルの判定
        let touchStart;
        let touchMove;
        imageContainer.addEventListener('touchstart', (event) => {
            touchStart = event.touches[0].clientX;
            touchMove = touchStart;
        });
        imageContainer.addEventListener('touchmove', (event) => {
            event.preventDefault();
            touchMove = event.touches[0].clientX;
        });
        imageContainer.addEventListener('touchend', (event) => {
            if (touchMove < touchStart - 20) {
                next();
            } else if (touchMove > touchStart + 20) {
                prev();
            }
        });

        let timer;
        function auto() {
            clearTimeout(timer);
            timer = setTimeout(() => {
                next();
            }, 3000);
        }
        auto();



    })();




})();