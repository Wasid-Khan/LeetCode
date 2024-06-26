/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    private List<TreeNode> sortedArr = new ArrayList<>();
    public TreeNode balanceBST(TreeNode root) {
    inorderTraverse(root);
    return sortedArrayToBST(0, sortedArr.size()-1);
    }

    private void inorderTraverse(TreeNode root){
        if(root == null) return;
        inorderTraverse(root.left);
        sortedArr.add(root);
        inorderTraverse(root.right);
    }

    private TreeNode sortedArrayToBST(int s, int e){
        if(s > e) return null;
        int mid = (s + e) / 2;
        TreeNode root = sortedArr.get(mid);
        root.left = sortedArrayToBST(s, mid -1);
        root.right = sortedArrayToBST(mid+1,e);
        return root;
    }
}