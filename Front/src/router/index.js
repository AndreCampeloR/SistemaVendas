import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

import ListarVendedorView from '../views/VendedorView/ListarVendedorView.vue'
import CadastrarVendedorView from '../views/VendedorView/CadastrarVendedorView.vue'
import AtualizarVendedorView from '../views/VendedorView/AtualizarVendedorView.vue'

import ListarCliente from '../views/ClienteView/ListarClienteView.vue'
import CadastrarCliente from '../views/ClienteView/CadastrarClienteView.vue'
import AtualizarCliente from '../views/ClienteView/AtualizarClienteView.vue'

import ListarServico from '../views/ServicoView/ListarServicoView.vue'
import CadastrarServico from '../views/ServicoView/CadastrarServicoView.vue'
import AtualizarServico from '../views/ServicoView/AtualizarServicoView.vue'


import ListarPedido from '../views/PedidoView/ListarPedidoView.vue'
import CadastrarPedido from '../views/PedidoView/CadastrarPedidoView.vue'
import AtualizarPedido from '../views/PedidoView/AtualizarPedidoView.vue'


import ListarItem from '../views/ItemPedidoView.vue/ListarItemView.vue'
import CadastrarItem from '../views/ItemPedidoView.vue/CadastrarItemView.vue'
import AtualizarItem from '../views/ItemPedidoView.vue/AtualizarItemView.vue'

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
    path: '/servico/listar',
    name: 'ListarServico',
    component: ListarServico
  },
  {
    path: '/servico/cadastrar',
    name: 'CadastrarServico',
    component: CadastrarServico
  },
  {
    path: '/servico/atualizar/:id',
    name: 'AtualizarServico',
    component: AtualizarServico
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
  {
    path: '/pedido/atualizar/:id',
    name: 'AtualizarPedido',
    component: AtualizarPedido
  },



  {
    path: '/itemPedido/listar',
    name: 'ListarItem',
    component: ListarItem
  },
  {
    path: '/itemPedido/cadastrar',
    name: 'CadastrarItem',
    component: CadastrarItem
  },
  {
    path: '/itemPedido/atualizar/:id',
    name: 'AtualizarItem',
    component: AtualizarItem
  },
  

]
const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
