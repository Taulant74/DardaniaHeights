const routes = [
    { path:'/guests', component:guests}
];

const router = new VueRouter({
    routes
});

const app = new Vue({
    router
}).$mount('#app');
