import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

import ListarVendedorView from '../views/VendedorView/ListarVendedorView.vue'
import CadastrarVendedorView from '../views/VendedorView/CadastrarVendedorView.vue'
import AtualizarVendedorView from '../views/VendedorView/AtualizarVendedorView.vue'

import ListarCliente from '../views/ClienteView/CadastrarCliente.vue'
import CadastrarCliente from '../views/ClienteView/CadastrarCliente.vue'
import AtualizarCliente from '../views/ClienteView/CadastrarCliente.vue'


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
    component: ListarVendedorView
  },
  {
    path: '/vendedor/cadastrar',
    name: 'CadastrarVendedor',
    component: CadastrarVendedorView
  },
  {
    path: '/vendedor/atualizar/:id',
    name: 'AtualizarVendedor',
    component: AtualizarVendedorView
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
    path: '/cliente/atualizar/:id',
    name: 'AtualizarCliente',
    component: AtualizarCliente
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
