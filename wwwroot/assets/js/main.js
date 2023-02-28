// Slider auto run
var counter = 1;
setInterval(function(){
    document.getElementById('radio-' + counter).checked = true;
    counter++;
    if(counter > 4){
    counter = 1;
    }
}, 5000);


const angleRightBtn = document.querySelector('.js-angle-right-btn')

function hideAngleRightBtn(){
    angleRightBtn.style.display = 'none'
    angleLeftBtn.style.display = 'block'
}

angleRightBtn.addEventListener('click', hideAngleRightBtn)

const angleRightBtn1 = document.querySelector('.js-angle-right-btn1')

function hideAngleRightBtn1(){
    angleRightBtn1.style.display = 'none'
    angleLeftBtn1.style.display = 'block'
}

angleRightBtn1.addEventListener('click', hideAngleRightBtn1)

const angleLeftBtn = document.querySelector('.js-angle-left-btn')

function hideAngleLeftBtn(){
    angleLeftBtn.style.display = 'none'
    angleRightBtn.style.display = 'block'

}

angleLeftBtn.addEventListener('click', hideAngleLeftBtn)

const angleLeftBtn1 = document.querySelector('.js-angle-left-btn2')

function hideAngleLeftBtn1(){
    angleLeftBtn1.style.display = 'none'
    angleRightBtn1.style.display = 'block'

}

angleLeftBtn1.addEventListener('click', hideAngleLeftBtn1)

/*=============== DARK LIGHT THEME ===============*/
const themeButton = document.getElementById('theme-button')
const darkTheme = 'dark-theme'
const iconTheme = 'ri-sun-line'

//Khai báo biến để lưu giao diện hiện tại
const selectedTheme = localStorage.getItem('selected-theme')
const selectedIcon = localStorage.getItem('selected-icon')

//Thực hiện lấy dữ liệu giao diện hiện tại
const getCurrentTheme = () => document.body.classList.contains(darkTheme) ? 'dark' : 'light'
const getCurrentIcon = () => themeButton.classList.contains(iconTheme) ? 'ri-moon-line' : 'ri-sun-line'

// Thực hiện điều kiện thay đổi giao diện và icon
if (selectedTheme) {
  document.body.classList[selectedTheme === 'dark' ? 'add' : 'remove'](darkTheme)
  themeButton.classList[selectedIcon === 'ri-moon-line' ? 'add' : 'remove'](iconTheme)
}

themeButton.addEventListener('click', () => {
// Thay đổi giao diện và icon
document.body.classList.toggle(darkTheme)
themeButton.classList.toggle(iconTheme)
// Check giao diện hiện tại
localStorage.setItem('selected-theme', getCurrentTheme())
localStorage.setItem('selected-icon', getCurrentIcon())
})



