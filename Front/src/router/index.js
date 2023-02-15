import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

import ListarVendedorView from '../views/VendedorView/ListarVendedorView.vue'
import CadastrarVendedorView from '../views/VendedorView/CadastrarVendedorView.vue'
import AtualizarVendedorView from '../views/VendedorView/AtualizarVendedorView.vue'

import ListarClienteView from '../views/ClienteView/ListarClienteView.vue'
import CadastrarClienteView from '../views/ClienteView/CadastrarClienteView.vue'
import AtualizarClienteView from '../views/ClienteView/AtualizarClienteView.vue'

import ListarServicoView from '../views/ServicoView/ListarServicoView.vue'
import CadastrarServicoView from '../views/ServicoView/CadastrarServicoView.vue'
import AtualizarServicoView from '../views/ServicoView/AtualizarServicoView.vue'


import ListarPedidoView from '../views/PedidoView/ListarPedidoView.vue'
import CadastrarPedidoView from '../views/PedidoView/CadastrarPedidoView.vue'
import AtualizarPedidoView from '../views/PedidoView/AtualizarPedidoView.vue'


import ListarItemView from '../views/ItemPedidoView.vue/ListarItemView.vue'
import CadastrarItemView from '../views/ItemPedidoView.vue/CadastrarItemView.vue'
import AtualizarItemView from '../views/ItemPedidoView.vue/AtualizarItemView.vue'

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
    component: ListarClienteView
  },
  {
    path: '/cliente/cadastrar',
    name: 'CadastrarCliente',
    component: CadastrarClienteView
  },
  {
    path: '/cliente/atualizar/:id',
    name: 'AtualizarCliente',
    component: AtualizarClienteView
  },



  {
    path: '/servico/listar',
    name: 'ListarServico',
    component: ListarServicoView
  },
  {
    path: '/servico/cadastrar',
    name: 'CadastrarServico',
    component: CadastrarServicoView
  },
  {
    path: '/servico/atualizar/:id',
    name: 'AtualizarServico',
    component: AtualizarServicoView
  },



  {
    path: '/pedido/listar',
    name: 'ListarPedido',
    component: ListarPedidoView
  },
  {
    path: '/pedido/cadastrar',
    name: 'CadastrarPedido',
    component: CadastrarPedidoView
  },
  {
    path: '/pedido/atualizar/:id',
    name: 'AtualizarPedido',
    component: AtualizarPedidoView
  },



  {
    path: '/itemPedido/listar',
    name: 'ListarItem',
    component: ListarItemView
  },
  {
    path: '/itemPedido/cadastrar',
    name: 'CadastrarItem',
    component: CadastrarItemView
  },
  {
    path: '/itemPedido/atualizar/:id',
    name: 'AtualizarItem',
    component: AtualizarItemView
  },
  

]
const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
