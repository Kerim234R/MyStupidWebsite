// Функция для добавления товара в корзину
function addToCart(name, price) {
    let cart = JSON.parse(localStorage.getItem('cart')) || {};
    
    if (cart[name]) {
        cart[name].quantity += 1;
    } else {
        cart[name] = {
            price: price,
            quantity: 1
        };
    }
    
    localStorage.setItem('cart', JSON.stringify(cart));
    updateCartDisplay();
}

// Функция для удаления товара из корзины
function removeFromCart(name) {
    let cart = JSON.parse(localStorage.getItem('cart')) || {};
    
    if (cart[name]) {
        cart[name].quantity -= 1;
        if (cart[name].quantity <= 0) {
            delete cart[name];
        }
    }
    
    localStorage.setItem('cart', JSON.stringify(cart));
    updateCartDisplay();
}

function isCartEmpty() {
    const cart = JSON.parse(localStorage.getItem('cart')) || {};
    return Object.keys(cart).length === 0;
}

function updateOrderButton() {
    const orderButton = document.getElementById('order-button');
    if (!orderButton) return;
    
    const isEmpty = isCartEmpty();
    orderButton.disabled = isEmpty;
    if(isEmpty) {
        orderButton.classList.add('disabled');
    } else {
        orderButton.classList.remove('disabled');
    }
}

//счётчик у корзины
function updateCartCounter() {
    const cart = JSON.parse(localStorage.getItem('cart')) || {};
    let totalItems = 0;
    
    for (const item of Object.values(cart)) {
        totalItems += item.quantity;
    }
    
    const cartLinks = document.querySelectorAll('a[href="pages/cart.html"], a[href="cart.html"]');
    cartLinks.forEach(cartLink => {
        const existingCounter = cartLink.querySelector('.cart-counter');
        let counter = existingCounter;
        
        if (!existingCounter) {
            counter = document.createElement('span');
            counter.className = 'cart-counter';
            cartLink.appendChild(counter);
        }
        
        if (totalItems > 0) {
            counter.textContent = `(${totalItems})`;
            counter.style.display = 'inline-block';
        } else {
            counter.style.display = 'none';
        }
    });
}

// Функция обновления отображения корзины
function updateCartDisplay() {
    const cartItems = document.getElementById('cart-items');
    const totalPrice = document.getElementById('total-price');
    const cart = JSON.parse(localStorage.getItem('cart')) || {};
    
    cartItems.innerHTML = '';
    let total = 0;
    
    for (const [name, item] of Object.entries(cart)) {
        const itemTotal = item.price * item.quantity;
        total += itemTotal;
        
        const itemElement = document.createElement('div');
        itemElement.className = 'cart-item';
        itemElement.innerHTML = `
            <div class="item-info">
                <div class="item-name">${name}</div>
            </div>
            <div class="quantity-controls">
                <button class="quantity-button" onclick="removeFromCart('${name}')">-</button>
                <span class="item-quantity">${item.quantity}</span>
                <button class="quantity-button" onclick="addToCart('${name}', ${item.price})">+</button>
            </div>
            <div class="item-price">${itemTotal} руб.</div>
        `;
        
        cartItems.appendChild(itemElement);
    }
    
    totalPrice.textContent = total;
    updateOrderButton();
    updateCartCounter();
}

// Обработчик кнопки "Заказать"
document.getElementById('order-button')?.addEventListener('click', () => {
    alert('Функция оформления заказа будет добавлена позже');
});

// Инициализация корзины при загрузке страницы
document.addEventListener('DOMContentLoaded', function() {
    updateCartDisplay();
    updateCartCounter();
    updateOrderButton();
});