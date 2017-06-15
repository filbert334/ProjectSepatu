//homepage
function ToDetailsProduct(id) {
  //  alert(id)
    window.location.replace("/Home/ProductDetails/" + id);

}

function FilterToListPage() {
    var _idType = $('#TypeFilter').val();
    var _idBrand = $('#BrandFilter').val();
    var _idCategory = $('#CategoryFilter').val();
    //alert(_idType)
    //alert(_idBrand)
    //alert(_idCategory)
    window.location.replace("/Home/List?idType=" + _idType + "&idBrand=" + _idBrand);

}

//details product

function AddToCart(id) {
 
    var _Qty = $('#QuantityField').val();
    var _Remarks = $('#CatatanField').val();
    alert(_Qty);
    window.location.replace("/Home/AddToCrt?id=" + id +"&qty=" + _Qty +"&remarks=" + _Remarks);

}
