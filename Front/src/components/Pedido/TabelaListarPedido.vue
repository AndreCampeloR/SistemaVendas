<template>
    <div class="col-7">
      <table class="table table-striped">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Data</th>
              <th scope="col">Id Vendedor</th>
              <th scope="col">Id Cliente</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="(pedido, index) in pedidos" :key="index">
              <th scope="row">{{ pedido.id }}</th>
              <td>{{ pedido.data }}</td>
              <td>{{ pedido.idVendedor }}</td>
              <td>{{ pedido.idCliente }}</td>
              <td>
                <button class="btn btn-success" @click="editarPedido(pedido.id)">Editar</button>
                <button class="btn btn-danger" @click="excluirPedido(pedido)">Excluir</button>
              </td>
            </tr>
          </tbody>
      </table>
    </div>
  </template>
  
  <script>
  import PedidoDataService from '../../services/PedidoDataService';
  export default {
    name: "TabelaListarPedido",
    data() {
      return{
        pedidos: []
      }
    },
    methods: {
      obterPedido() {
        PedidoDataService.listar()
          .then(response => this.pedidos = response.data)
      },
      editarPedido(id){
        this.$router.push("/pedido/atualizar/"+id)
      },
      async excluirPedido(pedido){
        if(confirm(`Tem certeza que deseja excluir o pedido ${pedido.id}`)){
          await PedidoDataService.deletar(pedido.id)
          this.obterPedidos();
        }
      }
    },
    mounted(){
      this.obterPedidos()
    }
  }
  </script>
  
  <style>
  </style>