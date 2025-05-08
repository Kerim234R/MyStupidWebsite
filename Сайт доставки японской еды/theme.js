// theme.js

// Функция для переключения темы
function toggleTheme() {
    const body = document.body;
    const leftSide = document.querySelector('.left-side');
    const welcomeText = document.querySelector('.welcome-text');
    const themeToggle = document.getElementById('theme-toggle');
    const icon = themeToggle.querySelector('i'); // Получаем элемент иконки

    if (body.classList.contains('dark-theme')) {
        // Переключение на светлую тему
        body.classList.remove('dark-theme');
        leftSide.classList.remove('dark-theme');
        if (welcomeText) welcomeText.classList.remove('dark-theme');
        icon.classList.remove('fa-moon'); // Убираем иконку луны
        icon.classList.add('fa-sun'); // Добавляем иконку солнца
        localStorage.setItem('theme', 'light');
    } else {
        // Переключение на темную тему
        body.classList.add('dark-theme');
        leftSide.classList.add('dark-theme');
        if (welcomeText) welcomeText.classList.add('dark-theme');
        icon.classList.remove('fa-sun'); // Убираем иконку солнца
        icon.classList.add('fa-moon'); // Добавляем иконку луны
        localStorage.setItem('theme', 'dark');
    }
}

// Функция для инициализации темы и кнопки
function initTheme() {
    const savedTheme = localStorage.getItem('theme');
    const body = document.body;
    const leftSide = document.querySelector('.left-side');
    const welcomeText = document.querySelector('.welcome-text');
    const themeToggle = document.getElementById('theme-toggle');

    if (themeToggle) {
        const icon = themeToggle.querySelector('i'); // Получаем элемент иконки

        if (savedTheme === 'dark') {
            // Устанавливаем темную тему
            body.classList.add('dark-theme');
            leftSide.classList.add('dark-theme');
            if (welcomeText) welcomeText.classList.add('dark-theme');
            icon.classList.remove('fa-sun');
            icon.classList.add('fa-moon');
        } else {
            // Устанавливаем светлую тему
            body.classList.remove('dark-theme');
            leftSide.classList.remove('dark-theme');
            if (welcomeText) welcomeText.classList.remove('dark-theme');
            icon.classList.remove('fa-moon');
            icon.classList.add('fa-sun');
        }

        // Добавление обработчика события для кнопки
        themeToggle.addEventListener('click', toggleTheme);
    }
}

// Инициализация темы при загрузке страницы
document.addEventListener('DOMContentLoaded', initTheme);