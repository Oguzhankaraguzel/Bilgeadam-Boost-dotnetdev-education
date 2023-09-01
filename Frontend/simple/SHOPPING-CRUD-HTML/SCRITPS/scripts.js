let product1 = { id: 1, name: "Bluetooth speaker", description: "JBL Charge5, Bluetooth Speaker, IPX7", price: 197, imagepath: "/IMAGES/Hoparlör.png" }

let product2 = { id: 2, name: "Keyboard", description: "GameBooster G25K Shock Türkçe RGB Membrane Gaming Keyboard | ITOPYA", price: 107, imagepath: "/IMAGES/Klavye.png" }

let product3 = { id: 3, name: "Wireless Headphones", description: "Batman Wireless On-Ear Headphones", price: 200, imagepath: "/IMAGES/Kulaklık.png" }

let product4 = { id: 4, name: "Laptop", description: "Microsoft Surface Laptop 4 13 Ryzen 5", price: 1200, imagepath: "/IMAGES/Laptop.png" }

let product5 = { id: 5, name: "Monitor", description: "Samsung LF24T350FHMXUF 24\" 75Hz 5ms (HDMI-D-Sub) FreeSync", price: 1000, imagepath: "/IMAGES/monitör.png" }

let product6 = { id: 6, name: "Mouse", description: "Logitech Lift Silent Wireless Ergonomic Vertical", price: 50, imagepath: "/IMAGES/Mouse.png" }

let products = [product1, product2, product3, product4, product5, product6];

const productContainer = document.getElementById('Product');

function GetProducts() {
    products.forEach(product => {
        const card = document.createElement('div');
        card.classList.add('card', 'm-1');
        card.style.width = '18rem';
        card.innerHTML = `
          <img src="${product.imagepath}" class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title">${product.name}</h5>
            <p class="card-text">${product.description}</p>
            <hr>
            ${product.price}$
            <a href="#" class="btn btn-primary w-100" onclick="AddProductsToCart(${product.id})">Add to Cart</a>
          </div>
        `;
        productContainer.appendChild(card);
    });
}

GetProducts();

function GetProductsBySearch() {
    let searchValue = document.getElementById('Search').value;
    let filterProducts = [];
    for (let product of products) {
        if (product.name.toLowerCase().includes(searchValue.toLowerCase())) {
            filterProducts.push(product);
        }
    }
    if (filterProducts.length === 0) {
        productContainer.innerHTML = "";
        GetProducts();
    }
    else {
        productContainer.innerHTML = "";
        filterProducts.forEach(product => {

            const card = document.createElement('div');
            card.classList.add('card', 'm-1');
            card.style.width = '18rem';
            card.innerHTML = `
              <img src="${product.imagepath}" class="card-img-top" alt="...">
              <div class="card-body">
                <h5 class="card-title">${product.name}</h5>
                <p class="card-text">${product.description}</p>
                <hr>
                ${product.price}$
                <a href="#" class="btn btn-primary w-100" onclick="AddProductsToCart(${product.id})">Add to Cart</a>
              </div>
            `;
            productContainer.appendChild(card);
        });
    }

}

let addedProduct = [];
let sum = 0;

function FillTheCart() {
    let cart = document.getElementById('Cart');

    cart.innerHTML = "";

    cart.innerHTML = `<il><div class="h5 m-2">AMOUNT = ${sum}$ <hr /><a href="#" class="btn btn-primary w-100">Finish Shopping</a></div></il><il><hr class="dropdown-divider" /></il>`;

    let cartItems = addedProduct.map((product, index) => `
    <li>
      <div class="card m-1" style="width: 18rem">
        <img src="${product.imagepath}" class="card-img-top" alt="...">
        <div class="card-body">
          <h5 class="card-title">${product.name}</h5>
          <p class="card-text">${product.description}</p>
          <hr />
          ${product.price}$
          <a href="#" class="btn btn-primary w-100" onclick="TakeOutProductFromCart(${index})">Take Out of The Cart</a>
        </div>
      </div>
    </li>
  `);

    cart.innerHTML += cartItems.join('');
}

function AddProductsToCart(id) {
    
    for (let product of products) {
        if (product.id == id) {
            addedProduct.push(product);
            sum += product.price;
        }
    }
    FillTheCart();

}

function TakeOutProductFromCart(index) {
    sum -= addedProduct[index].price;
    addedProduct.splice(index, 1);
    FillTheCart();

}





