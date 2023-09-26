function RedirectHome(){
  location.replace("/HTML/index.html");
}

function changetoHome(){
  location.replace("/HTML/index.html");
}

function changetoAbout(){
  location.replace("/HTML/about.html");
}

function changetoContact(){
  location.replace("/HTML/contact.html");
}

const stars=document.querySelectorAll('.star');
const current_rating=document.querySelector('.current-rating');

stars.forEach((star,index)=>{
  star.addEventListener('click',()=>{

    let current_star=index+1;
    current_rating.innerText=`${current_star} of 5`;

    stars.forEach((star,i)=>{
        if(current_star>=i+1){
          star.innerHTML='&#9733;';
        }else{
          star.innerHTML='&#9734;';
        }
    });

  });
});


// window.addEventListener("scroll", reveal);
// // To check the scroll position on page load
// reveal();
// function reveal() {
//   var reveals = document.querySelectorAll("#features-title");
//   for (var i = 0; i < reveals.length; i++) {
//     var windowHeight = window.innerHeight;
//     var elementTop = reveals[i].getBoundingClientRect().top;
//     var elementVisible = 250;
//     if (elementTop < windowHeight - elementVisible) {
//       reveals[i].classList.add(".features-title-animation");
//     } else {
//       reveals[i].classList.remove(".features-title-animation");
//     }
//   }
// }








// var scrollPos = window.scrollY; // window scroll position
// var wh = window.innerHeight-100; // as soon as element touches bottom with offset event starts
// var element = document.querySelector('#features-title'); //element

// window.addEventListener('scroll', function(){ 
//     if(scrollPos > (element.offsetTop - wh)){
//         element.classList.add('feature-title-animation');
//     }
// });


// $(window).scroll(function(){
//   var wh = $(window).height()-50;
//     if($(window).scrollTop() > $('#features-title').offset().top-wh){
//     $('#features-title').addClass('feature-title-animation');
//   }
// });

