/*==============================================================*/
/* Nom de SGBD :  PostgreSQL 8                                  */
/* Date de création :  10/04/2024 10:46:52                      */
/*==============================================================*/


drop table CARACTERISTIQUE;

drop table CATEGORIE;

drop table COMMANDE_ACHAT;

drop table DETAIL_CARACTERISTQUE;

drop table DETAIL_COMMANDE;

drop table FOURNISSEUR;

drop table FOURNIT;

drop table MAGASIN;

drop table PRODUIT;

drop table TYPE_PRODUIT;

/*==============================================================*/
/* Table : CARACTERISTIQUE                                      */
/*==============================================================*/
create table CARACTERISTIQUE (
   NUM_CARACTERISTIQUE  INT4                 not null,
   NOM_CARACTERISTQIQUE VARCHAR(50)          not null,
   constraint PK_CARACTERISTIQUE primary key (NUM_CARACTERISTIQUE)
);

/*==============================================================*/
/* Table : CATEGORIE                                            */
/*==============================================================*/
create table CATEGORIE (
   NUM_CATEGORIE        INT4                 not null,
   NUM_TYPE             INT4                 not null,
   LIBELLE_CATEGORIE    VARCHAR(100)         not null,
   constraint PK_CATEGORIE primary key (NUM_CATEGORIE)
);

/*==============================================================*/
/* Table : COMMANDE_ACHAT                                       */
/*==============================================================*/
create table COMMANDE_ACHAT (
   NUM_COMMANDE         SERIAL               not null,
   NUM_MAGASIN          INT4                 not null,
   MODE_TRANSPORT       VARCHAR(30)          not null,
   DATE_COMMANDE        DATE                 not null default current_date,
   DATE_LIVRAISON       DATE                 not null,
   MODE_LIVRAISON       VARCHAR(50)          not null
      
   constraint PK_COMMANDE_ACHAT primary key (NUM_COMMANDE)
	
);

/*==============================================================*/
/* Table : DETAIL_CARACTERISTQUE                                */
/*==============================================================*/
create table DETAIL_CARACTERISTQUE (
   NUM_PRODUIT          INT4                 not null,
   NUM_CARACTERISTIQUE  INT4                 not null,
   VALEUR_CARACTERISTIQUE VARCHAR(30)          null,
   constraint PK_DETAIL_CARACTERISTQUE primary key (NUM_PRODUIT, NUM_CARACTERISTIQUE)
);

/*==============================================================*/
/* Table : DETAIL_COMMANDE                                      */
/*==============================================================*/
create table DETAIL_COMMANDE (
   NUM_COMMANDE         INT4                 not null,
   NUM_PRODUIT          INT4                 not null,
   NUM_FOURNISSEUR      INT4                 not null,
   QUANTITE_COMMANDEE   INT4                 null
      constraint CKC_QUANTITE_COMMANDE_DETAIL_C check (QUANTITE_COMMANDEE between 1 and 100),
   constraint PK_DETAIL_COMMANDE primary key (NUM_COMMANDE, NUM_PRODUIT, NUM_FOURNISSEUR),
 constraint UQ_DETAIL_COMMANDE_NUM_COMMANDE_NUM_PRODUIT unique (NUM_COMMANDE, NUM_PRODUIT)
);



/*==============================================================*/
/* Table : FOURNISSEUR                                          */
/*==============================================================*/
create table FOURNISSEUR (
   NUM_FOURNISSEUR      INT4                 not null,
   NOM_FOURNISSEUR      VARCHAR(150)         not null,
   CODE_LOCAL           BOOL                 not null,
   constraint PK_FOURNISSEUR primary key (NUM_FOURNISSEUR)
);

/*==============================================================*/
/* Table : FOURNIT                                              */
/*==============================================================*/
create table FOURNIT (
   NUM_FOURNISSEUR      INT4                 not null,
   NUM_PRODUIT          INT4                 not null,
   PRIX_ACHAT           DECIMAL(7,2)         null,
   constraint PK_FOURNIT primary key (NUM_FOURNISSEUR, NUM_PRODUIT)
);

/*==============================================================*/
/* Table : MAGASIN                                              */
/*==============================================================*/
create table MAGASIN (
   NUM_MAGASIN          INT4                 not null,
   NOM_MAGASIN          VARCHAR(50)          not null,
   ADRESSE_RUE_MAGASIN  VARCHAR(50)          not null,
   ADRESSE_CP_MAGASIN   CHAR(5)              not null,
   ADRESSE_VILLE_MAGASIN VARCHAR(50)          not null,
   HORAIRE              CHAR(10)             null,
   constraint PK_MAGASIN primary key (NUM_MAGASIN)
);

/*==============================================================*/
/* Table : PRODUIT                                              */
/*==============================================================*/
create table PRODUIT (
   NUM_PRODUIT          SERIAL               not null,
   NUM_CATEGORIE        INT4                 not null,
   NOM_PRODUIT          VARCHAR(50)          not null,
   TAILLE_PRODUIT       VARCHAR(100)         not null,
   DESCRIPTION_PRODUIT  VARCHAR(200)         not null,
   PRIX_VENTE           DECIMAL(7,2)         not null,
   constraint PK_PRODUIT primary key (NUM_PRODUIT)
);

/*==============================================================*/
/* Table : TYPE_PRODUIT                                         */
/*==============================================================*/
create table TYPE_PRODUIT (
   NUM_TYPE             INT4                 not null,
   DESIGNATION_TYPE     VARCHAR(100)         not null,
   constraint PK_TYPE_PRODUIT primary key (NUM_TYPE)
);

alter table CATEGORIE
   add constraint FK_CATEGORI_FAIT_PART_TYPE_PRO foreign key (NUM_TYPE)
      references TYPE_PRODUIT (NUM_TYPE)
      on delete restrict on update restrict;

alter table COMMANDE_ACHAT
   add constraint FK_COMMANDE_CONCERNE_MAGASIN foreign key (NUM_MAGASIN)
      references MAGASIN (NUM_MAGASIN)
      on delete restrict on update restrict;

alter table DETAIL_CARACTERISTQUE
   add constraint FK_DETAIL_C_DETAIL_CA_PRODUIT foreign key (NUM_PRODUIT)
      references PRODUIT (NUM_PRODUIT)
      on delete restrict on update restrict;

alter table DETAIL_CARACTERISTQUE
   add constraint FK_DETAIL_C_DETAIL_CA_CARACTER foreign key (NUM_CARACTERISTIQUE)
      references CARACTERISTIQUE (NUM_CARACTERISTIQUE)
      on delete restrict on update restrict;

alter table DETAIL_COMMANDE
   add constraint FK_DETAIL_C_DETAIL_CO_COMMANDE foreign key (NUM_COMMANDE)
      references COMMANDE_ACHAT (NUM_COMMANDE)
      on delete restrict on update restrict;

alter table DETAIL_COMMANDE
   add constraint FK_DETAIL_C_DETAIL_CO_PRODUIT foreign key (NUM_PRODUIT)
      references PRODUIT (NUM_PRODUIT)
      on delete restrict on update restrict;

alter table DETAIL_COMMANDE
   add constraint FK_DETAIL_C_DETAIL_CO_FOURNISS foreign key (NUM_FOURNISSEUR)
      references FOURNISSEUR (NUM_FOURNISSEUR)
      on delete restrict on update restrict;

alter table FOURNIT
   add constraint FK_FOURNIT_FOURNIT_FOURNISS foreign key (NUM_FOURNISSEUR)
      references FOURNISSEUR (NUM_FOURNISSEUR)
      on delete restrict on update restrict;

alter table FOURNIT
   add constraint FK_FOURNIT_FOURNIT2_PRODUIT foreign key (NUM_PRODUIT)
      references PRODUIT (NUM_PRODUIT)
      on delete restrict on update restrict;

alter table PRODUIT
   add constraint FK_PRODUIT_APPARTENI_CATEGORI foreign key (NUM_CATEGORIE)
      references CATEGORIE (NUM_CATEGORIE)
      on delete restrict on update restrict;

