package gui;

import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class NewJFrame6 extends javax.swing.JFrame {

    Case c = new Case("", "", "", "","","");
    public NewJFrame6() throws Exception {
        initComponents();
        setSize(1300, 850);
        setLocation(150,15);
        setResizable(false);     
        
        c.LoadFromFile();
        for(int i =0 ; i<c.Cases.size();i++)
        {
            if(c.Cases.get(i).Indecator == 1)
                jComboBox1.addItem(c.Cases.get(i).Name);
        }
    }

   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jComboBox1 = new javax.swing.JComboBox();
        jButton2 = new javax.swing.JButton();
        jLabel5 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("delete outgoing");
        getContentPane().setLayout(null);

        jLabel1.setFont(new java.awt.Font("Arial", 3, 48)); // NOI18N
        jLabel1.setText("case name");
        getContentPane().add(jLabel1);
        jLabel1.setBounds(270, 310, 290, 60);

        jButton1.setFont(new java.awt.Font("Arial", 2, 36)); // NOI18N
        jButton1.setText("delete");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1);
        jButton1.setBounds(1010, 690, 170, 60);

        getContentPane().add(jComboBox1);
        jComboBox1.setBounds(730, 320, 280, 50);

        jButton2.setFont(new java.awt.Font("Arial", 2, 36)); // NOI18N
        jButton2.setForeground(new java.awt.Color(255, 51, 51));
        jButton2.setText("Back");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton2);
        jButton2.setBounds(1110, 33, 120, 50);

        jLabel5.setIcon(new javax.swing.ImageIcon(getClass().getResource("/gui/end.jpeg"))); // NOI18N
        getContentPane().add(jLabel5);
        jLabel5.setBounds(0, 0, 1280, 810);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        // TODO add your handling code here:
        this.setVisible(false); 
        NewJFrame5 g = new NewJFrame5();
        g.setVisible(true);
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        try {
            c.DeleteCase(jComboBox1.getSelectedItem().toString());
        } catch (Exception ex) {
            Logger.getLogger(NewJFrame6.class.getName()).log(Level.SEVERE, null, ex);
        }
         JOptionPane.showMessageDialog(this, "Deleted Sucssfully");
    }//GEN-LAST:event_jButton1ActionPerformed

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(NewJFrame6.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(NewJFrame6.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(NewJFrame6.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(NewJFrame6.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                try {
                    new NewJFrame6().setVisible(true);
                } catch (Exception ex) {
                    Logger.getLogger(NewJFrame6.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JComboBox jComboBox1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel5;
    // End of variables declaration//GEN-END:variables
}
