<template>
    <div id="cadastro-vendedor">
      <h3>Novo Item Pedido</h3>
      <div class="form" style="padding: 1%;">
          <h4>Pedido id: {{ this.$route.params.id}}</h4>
          <div>
              <label for="" class="form-label">Serviços</label>
              <br>
              <select name="servicos" id="servicos" v-model="cadastro.servicoId" class="form-select">
                  <option v-for="(servico, index) in Servicos" :key="index" :value="servico.id">{{ servico.nome }}</option>
              </select>
          </div>
          <div>
              <label for="" class="form-label">Quantidade</label>
              <br>
              <input type="number" v-model="cadastro.quantidade" class="form-control" min="1">
          </div>
          <div>
              <label for="" class="form-label">Valor</label>
              <br>
              <input type="number" v-model="cadastro.valor" class="form-control" min="1">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarItem">Cadastrar</button>
      </div>
    </div>
  </template>
  
  <script>
  import ServicoDataService from '../../services/ServicoDataService';
  import ItemPedidoDataService from '../../services/ItemPedidoDataService';
  export default {
      name: "FormCadastroItem",
      data(){
          return{
              cadastro: {
                  pedidoId: this.$route.params.id,
                  servicoId: "",
                  quantidade: "",
                  valor: ""
              },
              Servicos: [],
          }
      },
      methods: {
          cadastrarItem(){
              if(Number(this.cadastro.quantidade) <= 0 || Number(this.cadastro.valor) <= 0){
                  alert("Quantidade e valor devem ter um valor minimo de 1")
              }
              else{
                  ItemPedidoDataService.cadastrar(this.cadastro)
                  .then(() => {
                    console.log("deu")
                    this.$router.push('/itemPedido/pedido/' + this.cadastro.pedidoId)
                  })
              }
          },
          
      },
      mounted(){
          ServicoDataService.listar()
          .then((response) => {
              this.Servicos = response.data
          })
      }
  }
  </script>
  
  <style>
  </style>