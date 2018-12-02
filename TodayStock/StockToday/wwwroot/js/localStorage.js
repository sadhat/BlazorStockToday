function blazorDbSetItem(key, value) {
    localStorage.setItem(key, value);
    return true;
};

function blazorDbGetItem(key) {
    return localStorage.getItem(key);
};

function blazorDbRemoveItem(key) {
    return localStorage.removeItem(key);
};
