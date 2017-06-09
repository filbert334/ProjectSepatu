
function ToDetailsProduct(id) {
    alert(id)
    window.location.replace("/Home/ProductDetails/" + id);

}

function FilterToListPage(idType) {
    var values = idType.value;
    alert(values)
    window.location.replace("/Home/List/" + idType);

}