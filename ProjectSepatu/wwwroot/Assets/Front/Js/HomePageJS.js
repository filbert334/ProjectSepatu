//homepage
function ToDetailsProduct(id) {
  //  alert(id)
    window.location.replace("/Home/ProductDetails/" + id);

}

function FilterToListPage() {
    var values = $('#TypeFilter').val();
    alert(values)
    window.location.replace("/Home/List?idType=" + idType);

}

//details product

function AddToCart(id) {
    //  alert(id)
    window.location.replace("/Product/Cart/" + id);

}
