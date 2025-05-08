function toggleMenu() {
    const leftSide = document.querySelector('.left-side');
    leftSide.classList.toggle('active');
    
    const hamburger = document.querySelector('.hamburger');
    hamburger.classList.toggle('active');
}

// Закрываем меню при клике вне его области
document.addEventListener('click', (e) => {
    const leftSide = document.querySelector('.left-side');
    const hamburger = document.querySelector('.hamburger');
    
    if (!leftSide.contains(e.target) && !hamburger.contains(e.target)) {
        leftSide.classList.remove('active');
        hamburger.classList.remove('active');
    }
});