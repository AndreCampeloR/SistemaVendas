<template>
  <div class="col-7 d-flex flex-column align-items-center">
    <h2>Pedido {{ itemPedidoId }} - {{ Pedido.vendedor.nome }} - {{ Pedido.cliente.nome }}</h2>
    <p v-if="ItensPedido.length === 10">Esse pedido não possui nenhum item</p>
    <table class="table table-striped" v-else>
        <thead>
          <tr>
            <th scope="col">#</th>
            <th scope="col">Serviço</th>
            <th scope="col">Valor</th>
            <th scope="col">Quantidade</th>
            <th scope="col">SubTotal</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="(item, index) in ItensPedido" :key="index">
            <th scope="row">{{ item.id }}</th>
            <td scope="row">{{ item.servicoId }}</td>
            <td>{{ item.valor }}</td>
            <td>{{ item.quantidade }}</td>
            <td>{{ item.valor*item.quantidade }}</td>
            <td>
              <button class="btn btn-success" @click="editarPedido(item.id)">Editar</button>
              <button class="btn btn-danger" @click="excluirPedido(item)">Excluir</button>
            </td>
          </tr>
        </tbody>
        <tfoot>
          <tr>
            <th>Valor Total: {{ valorTotal() }}</th>
          </tr>
        </tfoot>
    </table>
    <button class="btn btn-primary" @click="adicionarNovoItem(Pedido.id)">Adicionar novo item</button>
  </div>
</template>
  
  <script>
  import ItemPedidoDataService from '../../services/ItemPedidoDataService';
  import PedidoDataService from '../../services/PedidoDataService.js';
  export default {
    name: "TabelaListarItem",
    data() {
      return{
        itemPedidoId: this.$route.params.id,
        ItensPedido: [],
        Pedido: {
          vendedor: {
            nome: ""
          },
          cliente: {
            nome: ""
          } 
        }
      }
    },
    methods: {
    async  obterItensPedido() {
    await ItemPedidoDataService.listarPorPedido(this.itemPedidoId)
               .then(response => this.ItensPedido = response.data)
          
      },
    async  obterPedidos() {
    await  PedidoDataService.obterPorId(this.itemPedidoId)
          .then(response => this.Pedido = response.data)
      },
      editarPedido(id){
        this.$router.push("/itemPedido/atualizar/"+id)
      },
      async excluirPedido(pedido){
        if(confirm(`Tem certeza que deseja excluir o pedido ${pedido.id}`)){
          await ItemPedidoDataService.deletar(pedido.id)
          this.obterItensPedido()
          console.log(this.Pedido)
        }
      },
      adicionarNovoItem(id){
        this.$router.push("/pedido/"+id+"/ItemPedido/cadastrar")
      },
      valorTotal(){
        let valorTotal = 0
        for(let cont=0; cont < this.ItensPedido.length; cont++){
          valorTotal+=this.ItensPedido[cont].valor*this.ItensPedido[cont].quantidade
        }
        return valorTotal.toLocaleString('pt-BR', {style: 'currency', currency: 'BRL'})
      }
    },
    beforeMount(){
     this.obterItensPedido()
     this.obterPedidos()
    }
  }
  </script>
  
  <style>
  </style>