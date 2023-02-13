import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

import ListarVendedor from '../views/Vendedor/ListarVendedor.vue'
import CadastrarVendedor from '../views/Vendedor/CadastrarVendedor.vue'

import ListarCliente from '../views/Cliente/CadastrarCliente.vue'
import CadastrarCliente from '../views/Cliente/CadastrarCliente.vue'

import ListarPedido from '../views/Pedido/CadastrarPedido.vue'
import CadastrarPedido from '../views/Pedido/CadastrarPedido.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },


  {
    path: '/vendedor/listar',
    name: 'ListarVendedor',
    component: ListarVendedor
  },
  {
    path: '/vendedor/cadastrar',
    name: 'CadastrarVendedor',
    component: CadastrarVendedor
  },


  {
    path: '/cliente/listar',
    name: 'ListarCliente',
    component: ListarCliente
  },
  {
    path: '/cliente/cadastrar',
    name: 'CadastrarCliente',
    component: CadastrarCliente
  },


  {
    path: '/pedido/listar',
    name: 'ListarPedido',
    component: ListarPedido
  },
  {
    path: '/pedido/cadastrar',
    name: 'CadastrarPedido',
    component: CadastrarPedido
  },
  

]
const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
